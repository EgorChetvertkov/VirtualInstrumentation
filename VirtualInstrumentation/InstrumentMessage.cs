namespace VirtualInstrumentation
{
    public class InstrumentMessage
    {
        public string Message { get; private set; }
        public int Code { get; private set; }
        public string Type { get; private set; }

        public InstrumentMessage(TypeMessage type, string message)
        {
            Code = (int)type;
            Type = type.ToString();
            Message = message;
        }

        public override string ToString()
        {
            return $"{Type}\n{Code}\n{Message}";
        }

        public override int GetHashCode()
        {
            return Code;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is InstrumentMessage other && other.Code == Code;
        }
    }
}