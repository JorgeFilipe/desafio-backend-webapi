using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models {

    public class Tarefa {
        [Key]
        public int Id { get; set; }

        [MinLength (1, ErrorMessage = "O título deve conter no mínimo 1 caracter")]
        [MaxLength (80, ErrorMessage = "O título deve conter no máximo 80 caracteres")]
        [Required (ErrorMessage = "Titulo obrigatorio")]
        public string Titulo { get; set; }

        [MinLength (20, ErrorMessage = "mínimo de 20 caracteres")]
        [MaxLength (160, ErrorMessage = "máximo de 160 caracteres")]
        public string Descricao { get; set; }

        [Required (ErrorMessage = "Data de Crição obrigatória")]
        public string DataCriacao { get; set; }

        [Required (ErrorMessage = "Data de Atualização obrigatória")]
        public string DataAtualizacao { get; set; }
    }
}