﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using threads;
using adapter;
using converter;
using targetManager;
using ASMLEngineSdk;
using modeType;

namespace controller
{
    class Controller
    {

        public bool Destroy(TargetManager target, IMissileLauncher launcher, ModeType Mode)
        {
            int number_of_targets = target.TargetList.Count / 7;
            int target_number = 1;

            while (target_number <= number_of_targets && !_shouldStop)
            {
                target.SetTarget(target_number);
                Converter coordinates = new Converter(target.X, target.Y, target.Z);
                switch (Mode)
                {                   
                    case ModeType.fireAll:
                        if (!_shouldStop)
                            launcher.MoveTo(coordinates.Phi, coordinates.Theta);
                        if (!_shouldStop)
                            launcher.Fire();
                        break;
                    case ModeType.fireFoes:
                        if (!target.Friend)
                        {
                            if (!_shouldStop)
                                launcher.MoveTo(coordinates.Phi, coordinates.Theta);
                            if (!_shouldStop)
                                launcher.Fire();
                        }
                        else
                        {
                        }
                        break;
                    case ModeType.fireFriends:
                        if (target.Friend)
                        {
                            if (!_shouldStop)
                                launcher.MoveTo(coordinates.Phi, coordinates.Theta);
                            if (!_shouldStop)
                                launcher.Fire();
                        }
                        else
                        {
                        }
                        break;
                }
                target_number++;
            }
            return true;
            
        }

        public bool Reset(IMissileLauncher launcher)
        {
            launcher.Reset();
            return true;
        }

        public void Start()
        {
            _shouldStop = false;
        }

        public void Stop()
        {
            _shouldStop = true;
        }

        private volatile bool _shouldStop;

    }
}
