﻿using System.Collections.Generic;
using CoinExchange.Trades.Application.OrderServices.Representation;
using CoinExchange.Trades.Application.TradeServices.Representation;
using CoinExchange.Trades.Domain.Model.TradeAggregate;

namespace CoinExchange.Trades.Application.TradeServices
{
    /// <summary>
    /// Interface for Trade Services
    /// </summary>
    public interface ITradeApplicationService
    {
        List<OrderRepresentation> GetTradesHistory(TraderId traderId, string offset = "", string type = "all",
            bool trades = false, string start = "", string end = "");

        List<OrderRepresentation> QueryTrades(TraderId traderId, string txId = "", bool includeTrades = false);
        IList<object> GetRecentTrades(string pair, string since);
        TradeVolumeRepresentation TradeVolume(string pair);
    }
}
