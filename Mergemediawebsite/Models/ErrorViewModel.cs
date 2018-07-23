using System;
using Mergemediawebsite.Models;

namespace Mergemediawebsite.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}