namespace BetaSeries.Net.Models
{
    public enum ErrorCode
    {
        #region API errors

        InvalidApiKey = 1001,

        InvalidType = 1002,

        InvalidAction = 1003,

        #endregion API errors

        #region User errors

        InvalidUserToken = 2001,

        UserPrivacySettings = 2002,

        ShowAlreadyInUserAcount = 2003,

        ShowNotnUserAcount = 2004,

        EpisodeNotSeenByUser = 2005,

        UsersAreNotFriends = 2006,

        InvalidUserOptions = 2007,

        #endregion User errors

        #region Variable errors

        MissingVariable = 3001,

        TermMustContainsAtLeastTwoCharacters = 3002,

        ParameterMustBeANumber = 3003,

        IncorrectVariableValue = 3004,

        UnauthorizedCharacters = 3005,

        InvalidEmail = 3006,

        #endregion Variable errors

        #region Database errors

        ShowDoesNotExists = 4001,

        UserDoesNotExists = 4002,

        IncorrectPassword = 4003,

        UserAlreadyExists = 4004

        #endregion Database errors
    }
}