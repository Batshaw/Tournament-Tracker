using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public interface IViewChanger
    {
        void PrizeComplete(PrizeModel model);
        void TeamComplete(TeamModel model);
        void TournamentComplete(TournamentModel model);
        void changeViewedTournament(TournamentModel model);
        void changeToTeamCreator();
        void changeToPrizeCreator();
        void changeToTournamentCreator();
        void changeToDashboard();
    }
}
