using System;
using System.Management.Automation;

namespace Illallangi.TheTvDb.Series
{
    [Cmdlet(VerbsCommon.Get, "TheTvDbSerie", DefaultParameterSetName = @"RetrieveSeries")]
    public sealed class GetRoute : TheTvDbCmdlet
    {
        [Parameter(Mandatory = false, ParameterSetName = @"RetrieveSeries")]
        public int? Id { get; set; }

        protected override void EndProcessing()
        {
            switch (this.ParameterSetName)
            {
                case @"RetrieveSeries":
                    this.WriteObject(this.Get<ISerieClient>()
                        .RetrieveSerieById(this.Id.Value)
                        .Result
                        .Data, true);
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
