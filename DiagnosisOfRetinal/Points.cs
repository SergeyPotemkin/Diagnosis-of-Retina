/*
    Copyright 2016,2017 Sergey Potemkin
    This file is part of the DOR.
   (Diagnosis of Retina)
   DOR is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License v3.0.
    
    You should have received a copy of the GNU General Public License v3.0
    along with DOR.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosisOfRetinal
{
    class Points
    {
        public List<DateTime> dates = new List<DateTime>();
        public List<double> _params = new List<double>();
        public List<double> _params2 = new List<double>();
    }
}
