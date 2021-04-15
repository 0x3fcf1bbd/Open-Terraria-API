﻿///*
//Copyright (C) 2020 DeathCradle

//This file is part of Open Terraria API v3 (OTAPI)

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program. If not, see <http://www.gnu.org/licenses/>.
//*/
//#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
//#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it

//using OTAPI;
//using ModFramework;
//using System;

//namespace Terraria
//{
//    class patch_Player : Terraria.Player
//    {

//        /** Begin Hook - Update */
//        public extern void orig_Update(int i);
//        public void Update(int i)
//        {
//            if (OTAPI.Hooks.Player.Update?.Invoke(HookEvent.Before, this, ref i, orig_Update) != HookResult.Cancel)
//            {
//                orig_Update(i);
//                OTAPI.Hooks.Player.Update?.Invoke(HookEvent.After, this, ref i, orig_Update);
//            }
//        }
//        /** End Hook - Update */
//    }
//}

//namespace OTAPI
//{
//    public static partial class Hooks
//    {
//        public static partial class Player
//        {
//            public delegate HookResult UpdateHandler(HookEvent @event, Terraria.Player instance, ref int i, Action<int> originalMethod);
//            public static UpdateHandler Update;
//        }
//    }
//}