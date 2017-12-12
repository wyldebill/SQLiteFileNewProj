using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace App7
{
    public interface ISQLite
    {
		SQLiteConnection GetAConnection();
    }
}
