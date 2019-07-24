﻿using System;
using System.Collections.Generic;
using Ooui;
using Samples.Storyboards;

namespace Samples
{
    class Program
    {
        static void Main (string[] args)
        {
            Xamarin.Forms.Forms.Init ();

            for (var i = 0; i < args.Length; i++) {
                var a = args[i];
                switch (args[i]) {
                    case "-p" when i + 1 < args.Length:
                    case "--port" when i + 1 < args.Length:
                        {
                            int p;
                            if (int.TryParse (args[i + 1], out p)) {
                                UI.Port = p;
                            }
                            i++;
                        }
                        break;
                }
            }

            var samples = new List<ISample>
            {
                new EntryListViewSample(),
                new ButtonSample (),
                new TodoSample (),
                new DrawSample (),
                new FilesSample(),
                new DisplayAlertSample (),
                new DotMatrixClockSample(),
                new EditorSample(),
                new MonkeysSample(),
                new BugSweeperSample(),
                new RefreshListViewSample (),
                new SearchBarSample(),
                new SliderSample(),
                new SwitchListViewSample(),
                new TimePickerSample(),
                new TipCalcSample(),
                new WeatherAppSample(),
                new XuzzleSample(),
                new WebViewSample(),
                new PickerSample(),
                new PlaygroundSample(),
            };

            foreach (var sample in samples)
            {
                sample.Publish();
            }

            var samplePage = new SamplePicker(samples);
            samplePage.Publish();

            UI.Present (samplePage.Path);

            Console.ReadLine ();
        }
    }
}
