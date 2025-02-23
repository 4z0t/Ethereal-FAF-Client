﻿using beta.Models.Server;
using beta.Models.Server.Enums;
using System;
using System.Globalization;
using System.Windows.Data;

namespace beta.Infrastructure.Converters
{
    public class ChatUserGroupConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;

            if (value is PlayerInfoMessage player)
            {
                if (player.IsChatModerator)
                    return "Moderators";

                return player.RelationShip switch
                {
                    PlayerRelationShip.Me => "Me",
                    PlayerRelationShip.Friend => "Friends",
                    PlayerRelationShip.None => "Players",
                    PlayerRelationShip.Foe => "Foes",
                    PlayerRelationShip.Clan => "Clan"
                };
            }
            else return "IRC users";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
