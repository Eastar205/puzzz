using System;
using System.Collections.Generic;

namespace Puzzz.Battle
{
    [Serializable]
    public class MonsterSpawn
    {
        public float hp;
        public float spawnDelay;
    }

    [Serializable]
    public class WaveDefinition
    {
        public int waveId;
        public float baseHp;
        public List<MonsterSpawn> monsters = new List<MonsterSpawn>();
    }
}
