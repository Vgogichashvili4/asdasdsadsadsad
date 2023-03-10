namespace webApi1.Models;

public class OrderHistory
{
    public int Id { get; set; }
    public long DeviceId { get; set;}
    public int OrderId { get; set;} 
    public long Imei { get; set; }
    public string? OrderType { get; set; }
    public string? DeviceName { get; set; }
    public bool InSent { get; set; } = false;
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}