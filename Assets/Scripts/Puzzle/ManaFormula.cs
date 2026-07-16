using UnityEngine;

namespace Puzzz.Puzzle
{
    public static class ManaFormula
    {
        private const float BaseManaPerOrb = 6f;
        private const float PurpleBaseDuration = 5f;
        private const float PurpleDurationPerExtraOrb = 1.5f;

        public static float CalculateManaGain(int chainLength)
        {
            return BaseManaPerOrb * chainLength * ChainBonusMultiplier(chainLength);
        }

        public static float CalculatePurpleBuffDuration(int chainLength)
        {
            return PurpleBaseDuration + Mathf.Max(0, chainLength - 2) * PurpleDurationPerExtraOrb;
        }

        private static float ChainBonusMultiplier(int chainLength)
        {
            if (chainLength >= 7) return 2f;
            if (chainLength >= 4) return 1.5f;
            return 1f;
        }
    }
}
