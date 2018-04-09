using System;

namespace TicTacToe.Models
{
    /// <summary>
    /// Приглашение на игру
    /// </summary>
    public class GameInvitationModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        /// <returns></returns>
        public Guid Id { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <returns></returns>
        public string EmailTo { get; set; }

        /// <summary>
        /// Кем приглашён
        /// </summary>
        /// <returns></returns>
        public string InvitedBy { get; set; }

        /// <summary>
        /// Подверждён ли
        /// </summary>
        /// <returns></returns>
        public bool IsConfirmed { get; set; }

        /// <summary>
        /// Дата подтверждения
        /// </summary>
        /// <returns></returns>
        public DateTime ConfirmationDate { get; set; }
    }
}