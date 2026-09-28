class Torch
{
    public bool status;
    public void On() => status = true;
    public void Off() => status = false;
    public string Output() => status ? "Đang bật" : "Đang tắt";

    public Torch(bool status)
    {
        this.status = status;
    }
}   