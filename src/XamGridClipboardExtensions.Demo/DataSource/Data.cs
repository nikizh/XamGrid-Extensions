using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace XamGridClipboardExtensions.Demo
{
    public class Data : INotifyPropertyChanged
    {
        #region Members

        private int _intData;
        private int? _nullableintData;
        private double _doubleData;
        private bool _boolData;
        private bool? _nullableBoolData;
        private string _stringData;
        private DateTime _dateTimeData;
        private Uri _uriData;
        private DataSource _dataItems;

        #endregion // Members

        #region Properties

        #region Int

        public int Int
        {
            get
            {
                return this._intData;
            }

            set
            {
                this._intData = value;
                this.RaisePropertyChanged(() => this.Int);
            }
        }

        #endregion // Int

        #region NInt

        public int? NInt
        {
            get
            {
                return this._nullableintData;
            }

            set
            {
                this._nullableintData = value;
                this.RaisePropertyChanged(() => this.NInt);
            }
        }

        #endregion // NInt

        #region Double

        public double Double
        {
            get
            {
                return this._doubleData;
            }

            set
            {
                this._doubleData = value;
                this.RaisePropertyChanged(() => this.Double);
            }
        }

        #endregion // Double

        #region Bool

        public bool Bool
        {
            get
            {
                return this._boolData;
            }

            set
            {
                this._boolData = value;
                this.RaisePropertyChanged(() => this.Bool);
            }
        }

        #endregion // Bool

        #region NBool

        public bool? NBool
        {
            get
            {
                return this._nullableBoolData;
            }

            set
            {
                this._nullableBoolData = value;
                this.RaisePropertyChanged(() => this.NBool);
            }
        }

        #endregion // NBool

        #region String

        public string String
        {
            get
            {
                return this._stringData;
            }

            set
            {
                this._stringData = value;
                this.RaisePropertyChanged(() => this.String);
            }
        }

        #endregion // String

        #region DateTime

        public DateTime DateTime
        {
            get
            {
                return this._dateTimeData;
            }

            set
            {
                this._dateTimeData = value;
                this.RaisePropertyChanged(() => this.DateTime);
            }
        }

        #endregion // DateTime

        #region Uri

        public Uri Uri
        {
            get
            {
                return this._uriData;
            }

            set
            {
                this._uriData = value;
                this.RaisePropertyChanged(() => this.Uri);
            }
        }

        #endregion // Uri

        #region DataItems

        public DataSource DataItems
        {
            get
            {
                if (this._dataItems == null)
                {
                    this._dataItems = new DataSource();
                }

                return this._dataItems;
            }

            set
            {
                this._dataItems = value;
                this.RaisePropertyChanged(() => this.DataItems);
            }
        }

        #endregion // DataItems

        #endregion // Properties

        #region Notification

        public event PropertyChangedEventHandler PropertyChanged;

        protected static string GetPropertyName<T>(Expression<Func<T>> action)
        {
            var expression = (MemberExpression)action.Body;
            return expression.Member.Name;
        }

        protected virtual void RaisePropertyChanged<T>(Expression<Func<T>> action)
        {
            string propertyName = GetPropertyName(action);

            this.OnPropertyChanged(propertyName);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion // Notification
    }
}
