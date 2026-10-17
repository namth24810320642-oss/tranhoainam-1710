using System;

namespace bai3
{
    public class RepairOrder
    {
        public string OrderId { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string DeviceType { get; set; } = string.Empty;
        public string IssueDescription { get; set; } = string.Empty;
        public DateTime ReceivedDate { get; set; } = DateTime.Now;
        public decimal EstimatedCost { get; set; } = 0m;
        public string Status { get; set; } = "Mới tiếp nhận";
        public string ImagePath { get; set; } = string.Empty;
    }
}