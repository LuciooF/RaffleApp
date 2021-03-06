#pragma checksum "C:\Users\lucia\source\repos\RaffleApp\RaffleApp\Views\Raffle\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e16cb7003a58eb280b35194de6fdccf204e58bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Raffle_index), @"mvc.1.0.view", @"/Views/Raffle/index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\lucia\source\repos\RaffleApp\RaffleApp\Views\_ViewImports.cshtml"
using RaffleApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lucia\source\repos\RaffleApp\RaffleApp\Views\_ViewImports.cshtml"
using RaffleApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e16cb7003a58eb280b35194de6fdccf204e58bf1", @"/Views/Raffle/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09cf6084e8727c27964fb99fc9040e32ba061f0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Raffle_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://cdn.jsdelivr.net/npm/vue/dist/vue.js""></script>
<script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">



<div id=""page-wrapper"" v-cloak>
    <div class=""row"">
        <div class=""col-lg-5 text-center"">
            <h1 class=""display-4"">Raffle!</h1>
            <div class=""row"">
                <div class=""col-lg-5""><h3>I want</h3></div>
                <div class=""col-lg-2""> <input class=""input-group form-control"" v-model=""winnersCount"" type=""number"" /></div>
                <div class=""col-lg-5""><h3>Winner/s!</h3></div>
            </div>
            <button class=""alert-danger"" v-on:click=""PickRaffleWinner()"">Pick raffle winners!</button>
            <div v-if=""winners.length");
            WriteLiteral(@" > 0"">
                <h2 class=""badge-success"">Winners!</h2>
                <div> <h5>ID, Name, Lastname</h5></div>
                <div v-for=""winner in winners"">
                    <div class=""alert-success"">{{winner.id}}, {{winner.firstName}}, {{winner.lastName}}</div>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 offset-lg-4 "">
            <button class=""alert-warning"" v-on:click=""PopulateDatabase"">Clear and repopulate Database</button>
            <div v-if=""people.length > 0"">
                <h2>People in database</h2>
                <div> <h5>ID, Name, Lastname</h5></div>
                <div v-for=""person in people"">
                    <div>{{person.id}}, {{person.firstName}}, {{person.lastName}}</div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    new Vue({
        el: '#page-wrapper',
        data: {
            people: [],
            winners: [],
            winnersCount: 3,
        }");
            WriteLiteral(@",
        methods: {
            PopulateDatabase: function () {
                var self = this;
                axios.get('/person/populatedatabase')
                    .then(response => {
                        self.people = response.data;
                    })
                    .catch(error => {
                        swal({ icon: 'error', text: error.response.data });
                    })
            },
            PickRaffleWinner: function () {
                var self = this;
                axios.put('/raffle/pickrafflewinners/' + self.winnersCount)
                    .then(response => {
                        self.winners = response.data;
                    })
                    .catch(error => {
                        swal({ icon: 'error', text: error.response.data });
                    })
            }
        },
        mounted: function () {
            this.PopulateDatabase();
        }
    });
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
