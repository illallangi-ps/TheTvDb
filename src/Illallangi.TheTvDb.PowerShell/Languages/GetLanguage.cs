using System;
using System.Management.Automation;

namespace Illallangi.TheTvDb.Languages
{
    [Cmdlet(VerbsCommon.Get, "TheTvDbLanguage", DefaultParameterSetName = @"RetrieveLanguages")]
    public sealed class GetRoute : TheTvDbCmdlet
    {
        [Parameter(Mandatory = false, ParameterSetName = @"RetrieveLanguages")]
        public int? Id { get; set; }

        protected override void EndProcessing()
        {
            switch (this.ParameterSetName)
            {
                case @"RetrieveLanguages":
                    if (this.Id.HasValue)
                    {
                        this.WriteObject(this.Get<ILanguageClient>()
                            .RetrieveLanguageById(this.Id.Value)
                            .Result
                            .Data, true);
                    }
                    else
                    {
                        this.WriteObject(this.Get<ILanguageClient>()
                            .RetrieveLanguages()
                            .Result
                            .Data, true);
                    }
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
