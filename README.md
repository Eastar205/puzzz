# Puzzz (가제)

퍼즐형 캐릭터 디펜스 - 드래그 체인 커넥트 퍼즐 + 오토배틀 디펜스 하이브리드 (Unity, iOS/Android)

## 폴더 구조

```
Puzzz/
  Assets/
    Scripts/
      Objects/   구슬(Orb) 색상, MatchObject 컴포넌트
      Puzzle/    체인 인접 판정(ChainRules), 마나/버프 계산식(ManaFormula), 리필형 보드(PuzzleBoard)
      Input/     드래그 체인 입력 처리(DragChainInputHandler)
      Battle/    캐릭터/마나/스킬(Character, CharacterRoster, SkillActivationMode),
                 몬스터/웨이브(Monster, WaveDefinition, WaveManager), 전투 진행(BattleManager)
      Core/      퍼즐-전투 연결 및 진행 관리(GameManager)
    Resources/
      Waves/     웨이브 데이터 JSON (wave_01)
    Prefabs/     구슬/캐릭터/몬스터 프리팹 (Unity 에디터에서 생성 필요)
    Scenes/      게임 씬 (Unity 에디터에서 생성 필요)
    Art/         스프라이트, 이미지 리소스
    Audio/       효과음, 배경음
  Packages/manifest.json   Unity 패키지 의존성
  ProjectSettings/         Unity 프로젝트 설정
  docs/GameConcept.md      게임 기획 컨셉 문서
```

## Unity 에디터에서 열기

1. Unity Hub에서 "Add" → 이 `Puzzz` 폴더 선택 (Unity 2022.3 LTS 권장)
2. 처음 열면 누락된 ProjectSettings 항목은 Unity가 자동으로 기본값 생성

## 남은 수동 작업 (에디터 GUI 필요)

1. **구슬 프리팹 5종** (Red/Blue/Green/Yellow/Purple)
   - 2D Sprite(원형) + Rigidbody2D + CircleCollider2D + `MatchObject` 컴포넌트 부착
2. **캐릭터 프리팹/오브젝트 4종** (전사/마법사/궁수/힐러)
   - `Character` 컴포넌트 부착, Element를 각각 Red/Blue/Green/Yellow로 설정
   - 체력/공격력/공격속도를 캐릭터별로 다르게 설정 (`docs/GameConcept.md` 5장 표 참고: 전사 200HP·마법사 느리고 강하게·궁수 빠르고 약하게·힐러 보조)
   - 상단 화면에 진형 순서(전사 → 마법사 → 궁수 → 힐러)대로 배치 후 `CharacterRoster`의 4개 슬롯에 연결
3. **몬스터 프리팹**
   - `Monster` 컴포넌트 부착, 이동 경로상 배치
4. **메인 게임 씬** (`Assets/Scenes/Main.unity`)
   - 하단 퍼즐 영역: `PuzzleBoard`, `DragChainInputHandler`, `GameManager` 배치 및 구슬 프리팹 슬롯 연결
   - 상단 전투 영역: `CharacterRoster`(4명 연결), `WaveManager`(몬스터 프리팹 / 스폰 위치 / **교전 지점(engagePoint)** / 기지 위치 / `CharacterRoster` 연결), `BattleManager` 배치
   - `GameManager`에 `PuzzleBoard`/`CharacterRoster`/`BattleManager`/`WaveManager` 참조 연결
   - 교전 지점(engagePoint)은 진형이 몬스터와 맞붙는 위치로, 스폰 지점과 기지 사이에 둠
5. Main Camera를 Orthographic으로 설정, 상단(전투)/하단(퍼즐) 두 영역이 화면에 모두 들어오도록 구성

## 핵심 메카닉 요약

- 하단 퍼즐은 7x7 격자, 매 순간 무작위 색(4속성 균등 + 보라 5%)으로 리필되는 무한 퍼즐 (`PuzzleBoard`)
- 드래그로 같은 색을 상하좌우로 연결, 손을 떼면 체인 확정 (`DragChainInputHandler`, `ChainRules`)
- 체인 색이 속성 볼이면 해당 캐릭터 마나 충전, 보라색이면 아군 전체 공격속도 버프 (`ManaFormula`, `GameManager`)
- 마나 100% 도달 시 자동 또는 수동으로 스킬 발동 (`Character.SkillMode`)
- 몬스터는 웨이브 단위로 스폰되어 진형(전사 → 마법사 → 궁수 → 힐러)의 최전방 생존자를 공격, 캐릭터는 자동 공격/스킬로 몬스터를 처치 (`WaveManager`, `Monster`, `BattleManager`)
- 진형이 전멸해야 몬스터가 기지에 도달하며, 도달 즉시 게임오버 (기지 체력 풀 없음) → `WaveManager.OnBaseDestroyed`
- 웨이브 몬스터 전멸 → 클리어, 자동으로 다음 웨이브 진행

## 로드맵
- 1차(현재): 핵심 루프 검증. 피버타임 제외, 캐릭터 4속성 고정
- 2차: 피버타임, 보라볼 킵 전략, 캐릭터 덱빌딩 (자세한 내용은 `docs/GameConcept.md` 참고)
