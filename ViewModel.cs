using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using WpfCommonHelper;

namespace SampleWpf
{
    public class AvailLenderHaircutRulesAdminViewModel : NotifyPropertyChanged
    {
        private ICommand _addExceptionCommand;
        private List<string> _haircuts = new List<string> { "10%", "15%", "20%", "30%", "40%", "50%" };
        private List<string> _countries = new List<string> { "US", "HK", "IN", "NG", "ALL" };

        private List<string> _lenderGroups = new List<string> { "2480", "2072" };
        private List<string> _lenderAccounts = new List<string> { "8888" };

        private ObservableCollection<AvailCountryLevelExceptions> _countryLevelExceptions = new ObservableCollection<AvailCountryLevelExceptions>();

        public AvailLenderHaircutRulesAdminViewModel()
        {
            CountryLevelExceptions.Add(AvailCountryLevelExceptions.Empty);
            CountryLevelExceptions.Add(new AvailCountryLevelExceptions {Country = "IN", GC = "10%"});
            CountryLevelExceptions.Add(new AvailCountryLevelExceptions { Country = "US", Warm = "30%" });
        }

        public ObservableCollection<AvailCountryLevelExceptions> CountryLevelExceptions
        {
            get { return _countryLevelExceptions; }
            set { _countryLevelExceptions = value; }
        }

        public List<string> Haircuts
        {
            get { return _haircuts; }
            set { _haircuts = value; }
        }

        public string DefaultAllCountries
        {
            get { return "10%"; }
        }

        public List<string> Countries
        {
            get { return _countries; }
        }

        public List<string> LenderGroups
        {
            get { return _lenderGroups; }
            set { _lenderGroups = value; }
        }

        public List<string> LenderAccounts
        {
            get { return _lenderAccounts; }
            set { _lenderAccounts = value; }
        }
    }

    public class AvailCountryLevelExceptions
    {
        public static AvailCountryLevelExceptions Empty = new AvailCountryLevelExceptions();

        public string Country { get; set; }
        public string DefaultHaircut { get; set; }
        public string DefaultHaircutOverride { get; set; }
        public string GC { get; set; }
        public string Warm { get; set; }
        public string HTB { get; set; }
    }
}
