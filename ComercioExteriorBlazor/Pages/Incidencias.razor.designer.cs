using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using ComercioExteriorBlazor.Data;
using ComercioExteriorBlazor.Models;
//using Blazor.Models.Sample;

using ComercioExteriorBlazor.Services;


namespace ComercioExteriorBlazor.Pages
{
    public partial class IncidenciasComponent : ComponentBase
    {
        public List<ComercioExteriorBlazor.Models.Observaciones> lObservaciones;

        public int idIncidencia = 0;

        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }


        protected RadzenDataGrid<ComercioExteriorBlazor.Models.Incidencia> grid0;

        bool _isEdit;
        protected bool isEdit
        {
            get
            {
                return _isEdit;
            }
            set
            {
                if (!object.Equals(_isEdit, value))
                {
                    var args = new PropertyChangedEventArgs() { Name = "isEdit", NewValue = value, OldValue = _isEdit };
                    _isEdit = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        ComercioExteriorBlazor.Models.Incidencia _incidencia;
        protected ComercioExteriorBlazor.Models.Incidencia incidencia 
        {
            get
            {
                return _incidencia;
            }
            set
            {
                if (!object.Equals(_incidencia, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "incidencia", NewValue = value, OldValue = _incidencia };
                    _incidencia = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }

        protected async System.Threading.Tasks.Task Load()
        {

        }

        protected async Task Grid0RowSelect(ComercioExteriorBlazor.Models.Incidencia args)
        {
            isEdit = true;

            //incidencia = args;

            DataAccess da = new DataAccess();
            idIncidencia = args.Id;
            if (da.cons_observaciones_by_id(args.Id, out List<Observaciones> incObs, out String msgError))
            {
                lObservaciones = incObs;
            }
        }   

        //protected async Task grIncidencias_RowSelect(ComercioExteriorBlazor.Models.Incidencia args)
        //{
        //    isEdit = true;

        //    //Incidencias = args;

        //    DataAccess da = new DataAccess();
        //    idIncidencia = args.Id;
        //    if (da.cons_observaciones_by_id(args.Id, out List<ComercioExteriorBlazor.Models.Observaciones> incObs, out String msgError))
        //    {
        //        lObservaciones = incObs;

        //    }
        //}

    }
}
