using IPClient.Shared.IServices;
using IPClient.Shared.Model;
using IPClient.Shared.ModelDto;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace IPClient.Shared.Services
{
    public class PingService : IPingService
    {
        private readonly ApiConfiguration _api;

        public PingService(ApiConfiguration api)
        {
            _api = api;
        }

        public async Task<Response> TestServer()
        {
            Response result = new Response();
            Ping testPing = new Ping();
            try
            {
                string server = _api.ServerHttp.Substring(7, _api.ServerHttp.Length - 12);
                PingReply reply = await testPing.SendPingAsync(server, 1000);
                if (reply == null)
                {
                    result.Success = false;
                    result.Errors = new List<string>() { "No response " };
                    return result;
                }
                if (reply.Status != IPStatus.Success)
                {
                    result.Success = false;
                    result.Errors = new List<string>() { reply.Status.ToString() };
                    return result;
                }
                result.Message = reply.RoundtripTime.ToString();
                return result;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Errors = new List<string>() { ex.Message };
                return result;
            }
        }
    }
}