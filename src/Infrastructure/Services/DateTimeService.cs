using MisterX.Application.Common.Interfaces;

namespace MisterX.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
