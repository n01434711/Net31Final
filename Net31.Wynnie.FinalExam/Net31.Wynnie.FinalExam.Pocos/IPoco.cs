using System;

namespace Net31.Wynnie.FinalExam.Pocos
{
    public interface IPoco
    {
        Guid Id { get; set; }

        byte[] TimeStamp { get; set; }
    }
}
