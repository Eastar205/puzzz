using System;
using System.Collections.Generic;

namespace Puzzz.Battle
{
    /// <summary>단일 몬스터 스폰 데이터 (웨이브 내 한 마리 정보)</summary>
    [Serializable]
    public class MonsterSpawn
    {
        /// <summary>몬스터 최대 HP</summary>
        public float hp;

        /// <summary>스폰 딜레이(초). 0이면 웨이브 시작과 동시에 등장</summary>
        public float spawnDelay;

        /// <summary>표시 이름</summary>
        public string label = "고블린";

        /// <summary>이동 속도 배율 (1 = 기본 Monster._moveSpeed)</summary>
        public float speedMultiplier = 1f;
    }

    /// <summary>웨이브 한 개의 전체 구성 데이터</summary>
    [Serializable]
    public class WaveDefinition
    {
        public int waveId;

        /// <summary>
        /// 웨이브에 속한 몬스터 스폰 목록.
        /// spawnDelay == 0인 항목들은 동시에 등장, 양수면 이전 스폰 이후 지연 등장.
        /// </summary>
        public List<MonsterSpawn> monsters = new List<MonsterSpawn>();
    }
}
