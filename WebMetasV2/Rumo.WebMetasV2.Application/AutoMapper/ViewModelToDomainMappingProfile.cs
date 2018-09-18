﻿using AutoMapper;
using Rumo.WebMetasV2.Application.ViewModels;
using Rumo.WebMetasV2.Domain.Commands.AreaCommands;
using Rumo.WebMetasV2.Domain.Commands.EscopoCommands;
using Rumo.WebMetasV2.Domain.Commands.GrupoPoolCommands;
using Rumo.WebMetasV2.Domain.Commands.IndicadorCommands;
using Rumo.WebMetasV2.Domain.Commands.UnidadeCommands;

namespace Rumo.WebMetasV2.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AreaViewModel, CadastrarAreaCommand>()
                .ConstructUsing(c => new CadastrarAreaCommand(c.Nome));
            CreateMap<AreaViewModel, AtualizarAreaCommand>()
                .ConstructUsing(c => new AtualizarAreaCommand(c.Id, c.Nome));

            CreateMap<EscopoViewModel, CadastrarEscopoCommand>()
                .ConstructUsing(c => new CadastrarEscopoCommand(c.Nome));
            CreateMap<EscopoViewModel, AtualizarEscopoCommand>()
                .ConstructUsing(c => new AtualizarEscopoCommand(c.Id, c.Nome));

            CreateMap<GrupoPoolViewModel, CadastrarGrupoPoolCommand>()
                .ConstructUsing(c => new CadastrarGrupoPoolCommand(c.Nome));
            CreateMap<GrupoPoolViewModel, AtualizarGrupoPoolCommand>()
                .ConstructUsing(c => new AtualizarGrupoPoolCommand(c.Id, c.Nome));

            CreateMap<UnidadeViewModel, CadastrarUnidadeCommand>()
                .ConstructUsing(c => new CadastrarUnidadeCommand(c.Nome));
            CreateMap<UnidadeViewModel, AtualizarUnidadeCommand>()
                .ConstructUsing(c => new AtualizarUnidadeCommand(c.Id, c.Nome));

            CreateMap<IndicadorViewModel, CadastrarIndicadorCommand>()
                .ConstructUsing(c => new CadastrarIndicadorCommand(c.Nome, c.DirecaoIndicador, c.TipoIndicador, c.MesInicio, c.MesFim));
            CreateMap<IndicadorViewModel, AtualizarIndicadorCommand>()
                .ConstructUsing(c => new AtualizarIndicadorCommand(c.Id, c.Nome, c.DirecaoIndicador, c.TipoIndicador, c.MesInicio, c.MesFim));
        }
    }
}
