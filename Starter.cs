using System;

namespace M02HW01;

    public class Starter
    {
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                var rand = new Random().Next(0, 3);
                Result result = null;
                switch (rand)
                {
                    case 0:
                    result = Actions.StartMethod();
                    break;
                    case 1:
                    result = Actions.SkipLogic();
                    break;
                    case 2:
                    result = result = Actions.BreakLogic();
                    break;
                }

                if (result != null && result.Status)
                {
                    Logger.Instance.LogError($"Action failed by a reason: {result.ErrorMessage}");
                }
            }

            var logs = Logger.Instance.GetAllLogs();
            File.WriteAllText("log.txt", logs);
        }
    }
