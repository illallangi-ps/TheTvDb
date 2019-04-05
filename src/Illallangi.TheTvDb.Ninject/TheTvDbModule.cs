using System;
using AutoMapper;
using Illallangi.TheTvDb.Languages;
using Illallangi.TheTvDb.Series;
using Illallangi.TheTvDb.Settings;
using Illallangi.TheTvDb.Tokens;
using Ninject;
using Ninject.Modules;

namespace Illallangi.TheTvDb
{
    public class TheTvDbModule : NinjectModule
    {
        public override void Load()
        {
            Bind<Authenticated.ClientHandler>().ToProvider<Authenticated.ClientHandlerProvider>();
            Bind<ILanguageClient>().ToProvider<Authenticated.RestServiceProvider<ILanguageClient>>();
            Bind<ISerieClient>().ToProvider<Authenticated.RestServiceProvider<ISerieClient>>();


            Bind<Anonymous.HttpClient>().ToProvider<Anonymous.HttpClientProvider>();
            Bind<ITokenClient>().ToProvider<Anonymous.RestServiceProvider<ITokenClient>>();

            Bind<IConfigurationProvider>().ToMethod(ctx => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<JsonSetting, ISetting>();
                cfg.CreateMap<JsonToken, IToken>();
            }));

            Bind<Func<JsonSetting, ISetting>>().ToMethod(ctx => ctx.Kernel.Get<IMapper>().Map<JsonSetting, ISetting>);
            Bind<Func<JsonToken, IToken>>().ToMethod(ctx => ctx.Kernel.Get<IMapper>().Map<JsonToken, IToken>);
            Bind<JsonSetting>().ToMethod(ctx => JsonSetting.Retrieve());
            Bind<JsonToken>().ToMethod(ctx => JsonToken.Retrieve());
            Bind<ISetting>().ToMethod(ctx => ctx.Kernel.Get<Func<JsonSetting, ISetting>>()(ctx.Kernel.Get<JsonSetting>()));
            Bind<IToken>().ToMethod(ctx => ctx.Kernel.Get<Func<JsonToken, IToken>>()(ctx.Kernel.Get<JsonToken>()));
            
            Bind<IMapper>().ToMethod(ctx => ctx.Kernel.Get<IConfigurationProvider>().CreateMapper());
        }
    }
}