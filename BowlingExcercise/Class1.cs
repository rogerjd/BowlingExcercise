using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingExcercise
{
    interface IGame
    {
        void Start();
        void Roll(int numOfPins);
        int[] ScoreByFrame();
        int TotalScore { get; }

    }
    public class BowlingScorer : IGame
    {
        int[] Frames = new int[10];

        int IGame.TotalScore => throw new NotImplementedException();

        public int Add()
        {
            return 0;
        }

        void IGame.Roll(int numOfPins)
        {
            throw new NotImplementedException();
        }

        int[] IGame.ScoreByFrame()
        {
            throw new NotImplementedException();
        }

        void IGame.Start()
        {
            throw new NotImplementedException();
        }
    }

    public class Game
    {
        int[] Frames = new int[10];
        int currentFrame;

        public void Start()
        {
            Array.Clear(Frames, 0, Frames.Length);
            currentFrame = 1;
        }

        public void Roll(int NumberOfPins)
        {

        }

        public int[] ScoreByFrame => Frames;

        public int TotalScore { get; }

        public int CurrentFrame => currentFrame;
    }
}
