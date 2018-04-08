using System;
using System.ComponentModel.DataAnnotations;

namespace TicTacToe.Models
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        /// <returns></returns>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        /// <returns></returns>
        [Required()]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        /// <returns></returns>
        [Required()]
        public string LastName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <returns></returns>
        [Required(), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        /// <returns></returns>
        [Required(), DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// Подтверждён ли email
        /// </summary>
        /// <returns></returns>
        public bool IsEmailConfirmed { get; set; }

        /// <summary>
        /// Дата подтверждения email
        /// </summary>
        /// <returns></returns>
        public DateTime? EmailConfirmationDate { get; set; }

        /// <summary>
        /// Очки
        /// </summary>
        /// <returns></returns>
        public int Score { get; set; }
    }
}