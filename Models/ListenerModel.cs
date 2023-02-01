namespace webApi1.Models;

public class ListenerModel
{
    
    public int ID { get; set; }
    public string? STARTBYTE { get; set;}
    public long IMEI { get; set;}
    public string? DATE  { get; set; }
    public string? ADMISSION_LEVEL { get; set; }
    public  string? PING { get; set; }
    public string? DOOR_STATUS { get; set; }
    public string? DOOR_CLOSE { get; set; }
    public string? DOOR_OPEN { get; set; }
    public string? RIGHT_DOOR { get; set; }
    public string? LEFT_DOOR { get; set; }
    public DateTime RECORDING_TIME { get; set; } = DateTime.Now;
  
    
}