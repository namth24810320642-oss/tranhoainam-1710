using System;

namespace bai2
{
    public class EquipmentBorrow
    {
        public string BorrowId { get; set; } = string.Empty;
        public string StudentId { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string EquipmentName { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;
        public DateTime BorrowDate { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(7);
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; } = "Đang mượn";
    }
}