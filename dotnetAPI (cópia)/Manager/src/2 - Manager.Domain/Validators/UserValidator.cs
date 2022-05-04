using FluentValidation;
namespace Manager.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia.")

                .NotNull()
                .WithMessage("A entidade não pode ser nula");

            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("O nome não pode ser nulo")

                .NotEmpty()
                .WithMessage("O nome não pode ser vazio")

                .MinimunLength(3)
                .WithMessage("O nome deve ter no mínimo 3 caracteres")

                .MaximunLength(80)
                .WithMessage("O nome deve ter no máximo 80 caracteres");

            RuleFor(x => x.Email)
                .NotNull()
                .WithMessage("O Email não pode ser nulo")

                .NotEmpty()
                .WithMessage("O Email não pode ser vazio")

                .MinimunLength(10)
                .WithMessage("O Email deve ter no mínimo 3 caracteres")

                .MaximunLength(180)
                .WithMessage("O Email deve ter no máximo 180 caracteres")

                .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                .WithMessage("O Email informado não é válido");

            RuleFor(x => x.Password)
                .NotNull()
                .WithMessage("A senha não pode ser nulo")

                .NotEmpty()
                .WithMessage("A senha não pode ser vazio")

                .MinimunLength(3)
                .WithMessage("A senha deve ter no mínimo 8 caracteres")

                .MaximunLength(80)
                .WithMessage("A senha deve ter no máximo 80 caracteres");
        }
    }
}