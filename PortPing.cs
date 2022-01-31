using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading;

namespace CiscoTools
{
    public class PortPing
    {
        private readonly int _count;
        private readonly string _host;
        private readonly int _port;
        private readonly int _timeout;
        private readonly int _wait;

        public PortPing(string host, int port, int timeout, int count, int wait)
        {
            _port = port;
            _host = host;
            _timeout = timeout;
            _count = count;
            _wait = wait;
        }

        public void Connect(BackgroundWorker worker,
            DoWorkEventArgs e)
        {
            int tries = 0;
            int success = 0;
            int fail = 0;
            double min = 0.0;
            double max = 0.0;
            double total = 0.0;

            var state = new CurrentState { Result = $"Connecting to {_host} on TCP {_port}:\n\n" };
            worker.ReportProgress(0, state);

            int count = _count != 0 ? _count : int.MaxValue;

            for (int i = 0; i < count; i++)
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    var client = new TcpClient();
                    var watch = new Stopwatch();
                    watch.Start();
                    IAsyncResult result = client.BeginConnect(_host, _port, null, null);
                    result.AsyncWaitHandle.WaitOne(_timeout);
                    if (client.Connected)
                    {
                        watch.Stop();
                        double time = watch.Elapsed.TotalMilliseconds;
                        // Math.Round(watch.Elapsed.TotalMilliseconds, 2);
                        state.Result = $"Connected to {_host}: time={time:0.00}ms protocol=TCP port={_port}\n";
                        success++;
                        tries++;
                        if (time < min || min == 0)
                            min = time;
                        if (time > max)
                            max = time;
                        total += time;
                        Thread.Sleep(_wait);
                    }
                    else
                    {
                        state.Result = "Connection timed out\n";
                        fail++;
                        tries++;
                    }
                    worker.ReportProgress(0, state);
                }
            Thread.Sleep(500);
            state.Result = $"\nConnection statistics:\n              Attempted = {tries}, Connected = {success}, Failed = {fail} ({(fail / tries):P})\nApproximate connection times:\n              Minimum = {min:0.00}ms, Maximum = {max:0.00}ms, Average = {total / tries:0.00}ms";
            worker.ReportProgress(0, state);
        }

        public class CurrentState
        {
            public string Result { get; set; }
        }
    }
}