using System;

namespace M02HW01
{
    public class Actions
    {
        public static Result StartMethod()
        {
            Logger.Instance.LogInfo($"Start method: {nameof(StartMethod)}");
            return new Result { Status = true };
        }

        public static Result SkipLogic()
        {
            Logger.Instance.LogWarning($"Skipped logic in method: {nameof(SkipLogic)}");
            return new Result { Status = true };
        }

        public static Result BreakLogic()
        {
            var errorMessage = "I broke a logic";
            Logger.Instance.LogError($"Action failed by a reason: {errorMessage}");
            return new Result { Status = false, ErrorMessage = errorMessage };
        }
    }

    public class Result
    {
        public bool Status { get; set; }

        public string ErrorMessage { get; set; }
    }
}