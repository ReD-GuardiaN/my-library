using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReD_GuardiaN
{
    public static class ReD
    {
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

            await Task.Run(()=> {
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
}
