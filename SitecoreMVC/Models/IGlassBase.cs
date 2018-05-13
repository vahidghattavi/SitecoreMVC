using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Models
{
    public interface IGlassBase
    {
        [SitecoreInfo(Glass.Mapper.Sc.Configuration.SitecoreInfoType.Name)]
        string Name { get; set; }

        [SitecoreInfo(Glass.Mapper.Sc.Configuration.SitecoreInfoType.TemplateName)]
        string TemplateName { get; set; }
    }
}
