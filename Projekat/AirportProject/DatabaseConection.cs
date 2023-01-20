using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace AirportProject

{
    public class DatabaseConection: IDisposable
    {
       
        private bool _disposed;
        private readonly IDriver _driver;

        public bool Disposed { get => _disposed; set => _disposed = value; }
        public IDriver Driver => _driver;

        ~DatabaseConection() => Dispose(false);

        public DatabaseConection(Uri uri, string user, string password)
        {
            try
            {
                _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (Disposed)
                return;

            if (disposing)
            {
                Driver?.Dispose();
            }
            Disposed = true;
        }

           


    }
}
/*
 < configSections >
    < sectionGroup name = "applicationSettings"
                  type = "System.Configuration.ApplicationSettingsGroup, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" >

      < section name = "Airport.Properties.Settings"
               type = "System.Configuration.ClientSettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
               requirePermission = "false" />

    </ sectionGroup >
  </ configSections >*/
