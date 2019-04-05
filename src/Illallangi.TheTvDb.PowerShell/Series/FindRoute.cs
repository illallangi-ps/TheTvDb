using System;
using System.Management.Automation;

namespace Illallangi.TheTvDb.Series
{
    [Cmdlet(VerbsCommon.Find, "TheTvDbSerie", DefaultParameterSetName = @"SearchSerie")]
    public sealed class FindRoute : TheTvDbCmdlet
    {
        [Parameter(Mandatory = false, ParameterSetName = @"SearchSerie")]
        public string Name { get; set; }

        protected override void EndProcessing()
        {
            switch (this.ParameterSetName)
            {
                case @"SearchSerie":
                    this.WriteObject(this.Get<ISerieClient>()
                        .SearchSerie(this.Name)
                        .Result
                        .Data, true);
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
