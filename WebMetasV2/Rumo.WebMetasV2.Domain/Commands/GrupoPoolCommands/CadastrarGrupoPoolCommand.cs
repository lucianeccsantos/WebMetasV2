﻿using Rumo.WebMetasV2.Domain.Validations.GrupoPoolValidations;
using System;

namespace Rumo.WebMetasV2.Domain.Commands.GrupoPoolCommands
{
    public class CadastrarGrupoPoolCommand : GrupoPoolCommand
    {
        public CadastrarGrupoPoolCommand(string nome)
        {
            Nome = nome;
        }

        public override bool IsValid()
        {
            ValidationResult = new CadastrarGrupoPoolCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
