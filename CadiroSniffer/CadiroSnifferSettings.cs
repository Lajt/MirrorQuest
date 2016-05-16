﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using Loki;
using Loki.Common;
using Newtonsoft.Json;
using CadiroSniffer.Classes;

namespace CadiroSniffer
{
    class CadiroSnifferSettings : JsonSettings
    {
        private static CadiroSnifferSettings _instance;

        public static CadiroSnifferSettings Instance => _instance ?? (_instance = new CadiroSnifferSettings());

        public CadiroSnifferSettings()
            : base(GetSettingsFilePath(Configuration.Instance.Name, string.Format("{0}.json", "CadiroSniffer")))
        {
            if(DGItemsCollection == null)
            {
                DGItemsCollection = new ObservableCollection<StringEntry>();
            }
            if(CommonCollection == null)
            {
                CommonCollection = new ObservableCollection<Common>();
            }
            if(OfferCollection == null)
            {
                OfferCollection = new ObservableCollection<Offer>();
            }
        }

        private ObservableCollection<StringEntry> _DGItemsCollection;
        private string _pushoverUserKey;
        private string _pushoverApiKey;
        private string _pushbulletKey;
        private string _prowlKey;

        private bool _pushoverEnabled;
        private bool _pushbulletEnabled;
        private bool _prowlEnabled;

        private bool _notifySuccess;
        private bool _notifyBotStop;
        private bool _notifyAll; // other

        private bool _autoCurrency;

        private bool _amuletBuy;
        private int _amuletPrice;
        private bool _ringBuy;
        private int _ringPrice;
        private bool _jewelBuy;
        private int _jewelPrice;
        private bool _mapBuy;
        private int _mapPrice;

        private ObservableCollection<Offer> _offerCollection;
        private ObservableCollection<Common> _commonCollection;

        [JsonIgnore]
        public ObservableCollection<Offer> OfferCollection
        {
            get { return _offerCollection; }
            set
            {
                _offerCollection = value;
                NotifyPropertyChanged(() => OfferCollection);
            }
        }

        [DefaultValue(null)]
        public ObservableCollection<StringEntry> DGItemsCollection
        {
            get { return _DGItemsCollection; }
            set
            {
                _DGItemsCollection = value;
                NotifyPropertyChanged(() => DGItemsCollection);
            }
        }

        [DefaultValue(null)]
        public ObservableCollection<Common> CommonCollection
        {
            get { return _commonCollection; }
            set
            {
                _commonCollection = value;
                NotifyPropertyChanged(() => CommonCollection);
            }
        }

        [DefaultValue(null)]
        public string PushoverUserKey
        {
            get { return _pushoverUserKey; }
            set
            {
                _pushoverUserKey = value;
                NotifyPropertyChanged(() => PushoverUserKey);
            }
        }

        [DefaultValue(null)]
        public string PushoverApiKey
        {
            get { return _pushoverApiKey; }
            set
            {
                _pushoverApiKey = value;
                NotifyPropertyChanged(() => PushoverApiKey);
            }
        }

        [DefaultValue(null)]
        public string PushbulletKey
        {
            get { return _pushbulletKey; }
            set
            {
                _pushbulletKey = value;
                NotifyPropertyChanged(() => PushbulletKey);
            }
        }

        [DefaultValue(null)]
        public string ProwlKey
        {
            get { return _prowlKey; }
            set
            {
                _prowlKey = value;
                NotifyPropertyChanged(() => ProwlKey);
            }
        }

        [DefaultValue(false)]
        public bool PushoverEnabled
        {
            get { return _pushoverEnabled; }
            set
            {
                _pushoverEnabled = value;
                NotifyPropertyChanged(() => PushoverEnabled);
            }
        }

        [DefaultValue(false)]
        public bool PushbulletEnabled
        {
            get { return _pushbulletEnabled; }
            set
            {
                _pushbulletEnabled = value;
                NotifyPropertyChanged(() => PushbulletEnabled);
            }
        }

        [DefaultValue(false)]
        public bool ProwlEnabled
        {
            get { return _prowlEnabled; }
            set
            {
                _prowlEnabled = value;
                NotifyPropertyChanged(() => ProwlEnabled);
            }
        }

        [DefaultValue(true)]
        public bool NotifySuccess
        {
            get { return _notifySuccess; }
            set
            {
                _notifySuccess = value;
                NotifyPropertyChanged(() => NotifySuccess);
            }
        }

        [DefaultValue(true)]
        public bool NotifyBotStop
        {
            get { return _notifyBotStop; }
            set
            {
                _notifyBotStop = value;
                NotifyPropertyChanged(() => _notifyBotStop);
            }
        }

        [DefaultValue(false)]
        public bool NotifyAll
        {
            get { return _notifyAll; }
            set
            {
                _notifyAll = value;
                NotifyPropertyChanged(() => NotifyAll);
            }
        }

        [DefaultValue(true)]
        public bool AutoCurrency
        {
            get { return _autoCurrency; }
            set
            {
                _autoCurrency = value;
                NotifyPropertyChanged(() => AutoCurrency);
            }
        }

        [DefaultValue(false)]
        public bool AmuletBuy
        {
            get { return _amuletBuy; }
            set
            {
                _amuletBuy = value;
                NotifyPropertyChanged(() => AmuletBuy);
            }
        }

        [DefaultValue(0)]
        public int AmuletPrice
        {
            get { return _amuletPrice; }
            set
            {
                _amuletPrice = value;
                NotifyPropertyChanged(() => AmuletPrice);
            }
        }

        [DefaultValue(false)]
        public bool RingBuy
        {
            get { return _ringBuy; }
            set
            {
                _ringBuy = value;
                NotifyPropertyChanged(() => RingBuy);
            }
        }

        [DefaultValue(0)]
        public int RingPrice
        {
            get { return _ringPrice; }
            set
            {
                _ringPrice = value;
                NotifyPropertyChanged(() => RingPrice);
            }
        }

        [DefaultValue(false)]
        public bool JewelBuy
        {
            get { return _jewelBuy; }
            set
            {
                _jewelBuy = value;
                NotifyPropertyChanged(() => JewelBuy);
            }
        }

        [DefaultValue(0)]
        public int JewelPrice
        {
            get { return _jewelPrice; }
            set
            {
                _jewelPrice = value;
                NotifyPropertyChanged(() => JewelPrice);
            }
        }

        [DefaultValue(false)]
        public bool MapBuy
        {
            get { return _mapBuy; }
            set
            {
                _mapBuy = value;
                NotifyPropertyChanged(() => MapBuy);
            }
        }

        [DefaultValue(0)]
        public int MapPrice
        {
            get { return _mapPrice; }
            set
            {
                _mapPrice = value;
                NotifyPropertyChanged(() => MapPrice);
            }
        }

        public class StringEntry
        {
            public string Name { get; set; }
        }
    }
}
