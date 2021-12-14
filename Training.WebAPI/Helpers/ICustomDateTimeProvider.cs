using System;

namespace Training.WebAPI.Helpers
{
    public interface ICustomDateTimeProvider
    {
        DateTime GetCurrentSystemDate();
    }
}