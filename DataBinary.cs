namespace NoSoliciting.Interface;

public class DataBinary {
    public ushort Channel { get; set; }
    public string Message { get; set; } = "";
    public bool IsNormal { get; set; }
}