﻿using Loki.Bot;
using Loki.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Windows.Controls;
using Default.EXtensions;
using Loki.Game;
using Loki.Game.Objects;

namespace MirrorQuest
{
    public class MirrorQuest : IPlugin, IStartStopEvents
    {
        public static readonly ILog Log = Logger.GetLoggerInstanceForType();

        public string Name => "MirrorQuest";
        public string Description => "Quest to find Mirror.";
        public string Author => "Lajt";
        public string Version => "1.0.2";
        
        #region Implementation of IBase

        /// <summary>Initializes this plugin.</summary>
        public void Initialize()
        {
            Log.DebugFormat($"[{Name}] Initialize");
        }

        /// <summary>Deinitializes this object. This is called when the object is being unloaded from the bot.</summary>
        public void Deinitialize()
        {
            Log.DebugFormat($"[{Name}] Deinitialize");
        }

        #endregion
        
        #region Implementation of IConfigurable

        /// <summary>The settings object. This will be registered in the current configuration.</summary>
        public JsonSettings Settings => MirrorQuestSettings.Instance;


        /// <summary> The plugin's settings control. This will be added to the Exilebuddy Settings tab.</summary>
        public UserControl Control => new Gui();

        #endregion

        #region Implementation of IRunnable

        /// <summary> The plugin start callback. Do any initialization here. </summary>
        public void Start()
        {
            Log.DebugFormat($"[{Name}] Start");
            var taskManager = BotStructure.TaskManager;
            taskManager.AddAfter(new CadiroOfferTask(), "PostCombatHookTask");
        }

        /// <summary> The plugin tick callback. Do any update logic here. </summary>
        public void Tick()
        {
        }

        /// <summary> The plugin stop callback. Do any pre-dispose cleanup here. </summary>
        public void Stop()
        {
            Log.DebugFormat($"[{Name}] Stop");
        }

        #endregion

        #region Implementation of IEnableable

        /// <summary> The plugin is being enabled.</summary>
        public void Enable()
        {
            Log.DebugFormat($"[{Name}] Enable");
        }

        /// <summary> The plugin is being disabled.</summary>
        public void Disable()
        {
            Log.DebugFormat($"[{Name}] Disable");
        }

        #endregion


        /// <inheritdoc />
        public MessageResult Message(Message message)
        {
            return MessageResult.Unprocessed;
        }

        /// <inheritdoc />
        public async Task<LogicResult> Logic(Logic logic)
        {
            return LogicResult.Unprovided;
        }
    }
}
