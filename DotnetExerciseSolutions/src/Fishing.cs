namespace DotnetExerciseSolutions
{
    public class Fishing
    {
        private static int FISH_EATEN = -1;
        private static int alive = 0;

        public static int GetAliveFishesFromStream(int[] fishesSize, int[] fishesOrientation)
        {
            alive = fishesSize.Length;

            return FishAlive(fishesSize, fishesOrientation);
        }

        public static int FishAlive(int[] fishesSize, int[] fishesOrientation)
        {
            int left = 0, right = 1, eaten = 0;

            while (right < fishesSize.Length)
            {
                if (!FishesAreFaceToFace(fishesOrientation[left], fishesOrientation[right]))
                {
                    left += 1;
                    right += 1;

                    continue;
                }

                if (CanLeftFishEatRightFish(fishesSize[left], fishesSize[right]))
                {
                    fishesSize[right] = FISH_EATEN;
                    alive--;

                    right += 1;
                    eaten += 1;
                }
                else if (IsFishStillAlive(fishesSize[left]))
                {
                    fishesSize[left] = FISH_EATEN;
                    alive--;

                    left = right;
                    right = right + 1;
                    eaten += 1;
                }
                else right++;
            }

            if (eaten == 0) return alive;

            return FishAlive(fishesSize, fishesOrientation);
        }

        private static bool IsFishStillAlive(int fishSize)
        {
            return fishSize != FISH_EATEN;
        }

        private static bool CanLeftFishEatRightFish(int leftFish, int rightFish)
        {
            return leftFish > rightFish && IsFishStillAlive(rightFish);
        }

        private static bool FishesAreFaceToFace(int leftFishDirection, int rightFishDirection)
        {
            return leftFishDirection > rightFishDirection;
        }
    }
}
