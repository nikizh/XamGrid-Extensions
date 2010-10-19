using System;
using System.Collections.ObjectModel;

namespace XamGridClipboardExtensions.Demo
{
    public class DataSource : ObservableCollection<Data>
    {
        #region Constructor

        public DataSource()
        {
        }

        public DataSource(int loadSize)
        {
            this.LoadData(loadSize);
        }

        #endregion // Constructor

        #region LoadData

        public void LoadData(int loadSize)
        {
            for (int i = 0; i < loadSize; i++)
            {
                int intData = i;
                bool? nullableBoolData = i % 3 == 0 ? false : i % 3 == 1 ? true : (bool?)null;

                bool boolData = (nullableBoolData == null) ? false : (bool)nullableBoolData;
                int? nullableIntData = (nullableBoolData == null) ? (int?)null : intData;

                double doubleData = i * 1.5;
                DateTime dateTimeData = new DateTime(2009, 5, (i % 24) + 1, i % 24, 0, 0);

                string stringData = string.Format("String {0}", i);
                Uri uriData = (nullableBoolData == null) ? null : new Uri("http://infragistics.com");
                DataSource dataItems = null;

                if (nullableBoolData != null)
                {
                    dataItems = new DataSource
                                    {
                                        new Data
                                            {
                                                Int = 1,
                                                Double = i,
                                                Bool = true,
                                                NBool = false,
                                                String = "Str",
                                                DateTime = DateTime.Now,
                                                Uri = new Uri("http://infragistics.com")
                                            },
                                        new Data
                                            {
                                                Int = 2,
                                                Double = i,
                                                Bool = false,
                                                NBool = null,
                                                String = null,
                                                DateTime = DateTime.Now,
                                                Uri = null
                                            },
                                        new Data
                                            {
                                                Int = 3,
                                                Double = i * 2.5,
                                                Bool = false,
                                                NBool = true,
                                                String = "str",
                                                DateTime = DateTime.Now,
                                                Uri = new Uri("http://infragistics.com")
                                            }
                                    };
                }

                this.Add(new Data
                {
                    Int = intData,
                    NInt = nullableIntData,
                    Double = doubleData,
                    Bool = boolData,
                    NBool = nullableBoolData,
                    String = stringData,
                    DateTime = dateTimeData,
                    Uri = uriData,
                    DataItems = dataItems
                });
            }
        }

        #endregion // LoadData
    }
}
