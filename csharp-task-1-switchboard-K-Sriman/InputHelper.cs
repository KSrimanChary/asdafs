using System;
using PresentationLogic;

namespace model
{
    public static class InputHelper
    {
        public static int GetDeviceValue<T>(this T device , string deviceName)
        {
            return ValidationChecker.GetValidatedInput($"Enter number of {deviceName}: ");
        }
    }
}