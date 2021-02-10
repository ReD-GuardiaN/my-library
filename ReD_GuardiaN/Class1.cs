using System;
using System.Threading;
using System.Threading.Tasks;

namespace ReD_GuardiaN {
    public static class ReD {
        public async static void Logo() {

            string[] frames = {
            "_",
            "_",
            "_",
            "-",
            "`",
            "`",
            "'",
            "´",
            "-",
            "_",
            "_",
            "_"
            };

            const string logo = "===>ReD_GuardiaN";

            await Task.Run(() => {
                while (true) {
                    for (int i = 0; i < 3; i++) {
                        foreach (var item in frames) {
                            Thread.Sleep(80);
                            Console.Title = item;
                        }
                    }

                    Console.Title = "";
                    foreach (var item in logo) {
                        Console.Title += item;
                        Thread.Sleep(80);
                    }

                    Thread.Sleep(920);
                    for (int i = Console.Title.Length; i > 0; i--) {
                        Thread.Sleep(80);
                        Console.Title = Console.Title.Substring(0, i);
                    }
                }
            });
        }
    }

    public static class Read {

        public static int Int(string preMess = "", bool newLine = true) {

            Console.Write(preMess);
            string output = "";
            char input;

            do {
                input = Console.ReadKey(true).KeyChar;
                if ((ConsoleKey)input == ConsoleKey.Enter) break;

                if (Char.IsDigit(input) || (output.Length == 0 && input == '-')) {
                    output += input;
                    Console.Write(input);
                }

                if ((ConsoleKey)input == ConsoleKey.Backspace && output.Length > 0) {
                    output = output.Substring(0, output.Length - 1);
                    EraseChar();
                }
            } while (true);
            if (newLine) Console.WriteLine();
            return int.Parse(output);
        }

        private static void EraseChar() {
            Console.CursorLeft--;
            Console.Write(' ');
            Console.CursorLeft--;
        }


        public static double Double(string preMess = "", bool newLine = true) {
            Console.Write(preMess);
            string output = "";
            char input;

            do {
                input = Console.ReadKey(true).KeyChar;
                if ((ConsoleKey)input == ConsoleKey.Enter) break;

                if (Char.IsDigit(input) || (output.Length == 0 && input == '-') || (output.Length > 0 && !output.Contains(",") && input == ',')) {
                    output += input;
                    Console.Write(input);
                }

                if ((ConsoleKey)input == ConsoleKey.Backspace && output.Length > 0) {
                    output = output.Substring(0, output.Length - 1);
                    EraseChar();
                }
            } while (true);
            if (newLine) Console.WriteLine();
            return double.Parse(output);
        }
    }
}