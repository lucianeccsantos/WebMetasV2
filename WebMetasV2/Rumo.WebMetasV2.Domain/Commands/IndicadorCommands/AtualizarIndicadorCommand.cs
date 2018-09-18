﻿using Rumo.WebMetasV2.Domain.Validations.IndicadorValidations;
using System;

namespace Rumo.WebMetasV2.Domain.Commands.IndicadorCommands
{
    public class AtualizarIndicadorCommand : IndicadorCommand
    {
        public AtualizarIndicadorCommand(Guid id, string nome, Enumeradores.Enumerador.DirecaoIndicador direcaoIndicador,
                                         Enumeradores.Enumerador.TipoIndicador tipoIndicador, Enumeradores.Enumerador.Mes mesInicio,
                                         Enumeradores.Enumerador.Mes mesFim)
        {
            Id = id;
            Nome = nome;
            DirecaoIndicador = direcaoIndicador;
            TipoIndicador = tipoIndicador;
            MesInicio = mesInicio;
            MesFim = mesFim;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new AtualizarIndicadorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
