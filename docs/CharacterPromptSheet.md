# Puzzz 캐릭터 이미지 생성 AI 프롬프트 시트 (모션 액션 포함 버전)

이 문서는 24인 캐릭터들의 설정(성별, 종족, 장르, 스킬 이펙트)을 기반으로 미드저니(Midjourney)나 DALL-E 3 등 이미지 생성 AI에서 **2등신 모바일 캐주얼 스타일이자 왼쪽을 바라보는 2D 리깅 애니메이션 분할 파츠 원화**를 추출하고, 5개 액션 모션에 맞춰 자세를 변형할 수 있도록 설계된 영문 프롬프트 가이드라인입니다.

---

## 🎨 5대 모션 액션 프롬프트 변환 가이드 (5개의 개별 이미지 생성용)
각 캐릭터 프롬프트에서 동작을 변경하고 싶다면, 프롬프트 내부의 `pose` 키워드 부위에 아래 5가지 액션 프롬프트 구문을 교체하여 대입하세요.

1. **[대기 모션 (Idle Pose)]**:
   - 아군 진영에서 무기를 쥔 채 가만히 숨 고르기를 하는 기본 스탠딩 자세
   - 추가 키워드: `in neutral idle stance, standing pose, holding weapon naturally, relaxed shoulders`
2. **[준비자세 모션 (Ready Pose)]**:
   - 스킬 마나가 다 차서 스킬을 쓰기 전 기를 모으거나 전투 태세를 갖춘 긴장감 있는 자세
   - 추가 키워드: `in combat ready stance, charging energy, eyes glowing, determined expression, body tensed`
3. **[타격/공격 모션 (Attack/Strike Pose)]**:
   - 무기를 휘두르거나 투사체를 발사하여 에너지가 뻗어 나가는 다이내믹한 연출 자세
   - 추가 키워드: `in dynamic attack strike pose, swinging weapon forward with light trails, projectile muzzle flash effect`
4. **[회복/피격 복구 모션 (Heal/Recover Pose)]**:
   - 치료를 받아 초록빛/빛의 이펙트가 온몸을 감싸며 안도하거나 자세를 바로잡는 연출 자세
   - 추가 키워드: `in healing recovery pose, surrounded by glowing green healing sparkles and holy light beams`
5. **[기절/사망 모션 (Faint/Stunned Pose - HP 0)]**:
   - 체력이 다해 눈이 감기거나 핑핑 도는 이펙트(😵)와 함께 뒤로 쓰러져 널부러진 자세
   - 추가 키워드: `in defeated knocked out pose, falling backward, stars dizzy effect, eyes closed, lying down`

---

## 🛡️ 전사 (Warrior)

### 1. 백산 (무협 / 뇌신검객)
- **설정**: 남성 / 인간 / 뇌신검객
- **모션별 프롬프트**:
  - **대기 (Idle)**:
    ```text
    chibi 2-head-tall style, casual mobile game asset, facing left, character spritesheet, Male, Human eastern martial arts swordsman, white robes, in neutral idle stance, holding a sword wrapped in soft electric sparks, flat 2d game vector style, white background
    ```
  - **준비 (Ready)**:
    ```text
    chibi 2-head-tall style, casual mobile game asset, facing left, character spritesheet, Male, Human eastern martial arts swordsman, in combat ready stance charging blue lightning energy, eyes glowing blue, flat 2d game vector style, white background
    ```
  - **타격 (Attack)**:
    ```text
    chibi 2-head-tall style, casual mobile game asset, facing left, character spritesheet, Male, Human eastern martial arts swordsman, in dynamic attack strike pose swinging sword forward with blue lightning trail, flat 2d game vector style, white background
    ```
  - **회복 (Recover)**:
    ```text
    chibi 2-head-tall style, casual mobile game asset, facing left, character spritesheet, Male, Human eastern martial arts swordsman, in healing recovery pose surrounded by glowing green healing sparkles, flat 2d game vector style, white background
    ```
  - **기절 (Faint)**:
    ```text
    chibi 2-head-tall style, casual mobile game asset, facing left, character spritesheet, Male, Human eastern martial arts swordsman, in defeated knocked out pose, falling backward with dizzy stars effect, eyes closed, flat 2d game vector style, white background
    ```

### 2. 가이아 (판타지 / 대지 골렘)
- **설정**: 무성 / 정령 (골렘)
- **모션별 프롬프트**:
  - **대기 (Idle)**:
    ```text
    chibi 2-head-tall style, casual mobile game asset, facing left, Rock golem element protector, in neutral idle stance, moss growing on shoulders, flat 2d game vector style, white background
    ```
  - **준비 (Ready)**:
    ```text
    chibi 2-head-tall style, casual mobile game asset, facing left, Rock golem, in combat ready stance, body cracks glowing with bright green earth energy shield, flat 2d game vector style, white background
    ```
  - **타격 (Attack)**:
    ```text
    chibi 2-head-tall style, casual mobile game asset, facing left, Rock golem, in dynamic attack strike pose punching ground creating rocky spikes rising forward, flat 2d game vector style, white background
    ```
  - **회복 (Recover)**:
    ```text
    chibi 2-head-tall style, casual mobile game asset, facing left, Rock golem, in healing recovery pose, stone body mending with glowing green healing light, flat 2d game vector style, white background
    ```
  - **기절 (Faint)**:
    ```text
    chibi 2-head-tall style, casual mobile game asset, facing left, Rock golem, in defeated knocked out pose, crumbled stone parts lying down, eyes dim, flat 2d game vector style, white background
    ```

### 3. 이지스 (SF 미래 / 안드로이드 중장갑 기병)
- **설정**: 무성 / 기계 / 중장갑 방패 기병
- **모션별 프롬프트 (대기/준비/타격/회복/기절)**:
  - **대기 (Idle)**: `chibi 2-head-tall robot knight, facing left, in neutral idle stance holding a giant mechanical shield, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall robot knight, facing left, in combat ready stance charging blue energy barrier into the shield, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall robot knight, facing left, in dynamic attack strike pose bashing forward with shield emitting a cyan shockwave, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall robot knight, facing left, in healing recovery pose, nano-bots repairing metal plates with orange glowing particles, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall robot knight, facing left, in defeated knocked out pose, system offline, sparks leaking, slumped on floor, flat 2d game vector style, white background`

### 4. 시구르드 (서양 신화 / 바이킹 전사)
- **설정**: 남성 / 반신 / 바이킹 전사
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall style 바이킹 전사, facing left, in neutral idle stance resting a waraxe on shoulder, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall style 바이킹 전사, facing left, in combat ready stance yelling with golden warrior aura charging, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall style 바이킹 전사, facing left, in dynamic attack strike pose swinging waraxe downward with golden light trails, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall style 바이킹 전사, facing left, in healing recovery pose surrounded by glowing green valkyrie feathers, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall style 바이킹 전사, facing left, in defeated knocked out pose, lying backward, broken axe next to him, eyes closed, flat 2d game vector style, white background`

### 5. 랑하 (동양풍 / 사자탈 요수)
- **설정**: 여성 / 수인 / 사자탈 요수
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall lion dancer beast girl, facing left, in neutral idle stance wearing red lion mask head, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall lion dancer beast girl, facing left, in combat ready stance paws glowing with golden sonic energy, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall lion dancer beast girl, facing left, in dynamic attack strike pose pawing forward with red sonic wave ripples, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall lion dancer beast girl, facing left, in healing recovery pose surrounded by green leaves and healing sparkles, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall lion dancer beast girl, facing left, in defeated knocked out pose, mask fallen to side, lying down dizzy, flat 2d game vector style, white background`

### 6. 잔다르크 (역사 과거 / 성기사)
- **설정**: 여성 / 인간 / 성기사
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall holy paladin, facing left, in neutral idle stance holding light banner flag, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall holy paladin, facing left, in combat ready stance banner glowing with divine white halo, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall holy paladin, facing left, in dynamic attack strike pose thrusting banner forward with white light shield wave, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall holy paladin, facing left, in healing recovery pose bathed in holy white light beam, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall holy paladin, facing left, in defeated knocked out pose, kneeling down, hands on floor, flag broken, flat 2d game vector style, white background`

---

## 🔮 마법사 (Mage)

### 7. 제피로스 (판타지 / 비전 대마법사)
- **설정**: 남성 / 엘프
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall Elf mage, facing left, in neutral idle stance holding staff, flowy purple robes, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall Elf mage, facing left, in combat ready stance summoning floating magic runes, staff tip glowing purple, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall Elf mage, facing left, in dynamic attack strike pose casting a giant purple arcane portal blast forward, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall Elf mage, facing left, in healing recovery pose, floating green magical circles mending wounds, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall Elf mage, facing left, in defeated knocked out pose, falling backward, staff rolled away, flat 2d game vector style, white background`

### 8. 화린 (무협 / 적련화사)
- **설정**: 여성 / 인간
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall eastern fire mage, facing left, red hanfu dress, in neutral idle stance, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall eastern fire mage, facing left, in combat ready stance fire sparks dancing around hands, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall eastern fire mage, facing left, in dynamic attack strike pose launching a giant snake made of fire forward, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall eastern fire mage, facing left, in healing recovery pose surrounded by green light and fire embers, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall eastern fire mage, facing left, in defeated knocked out pose, lying flat on floor, dress singed, flat 2d game vector style, white background`

### 9. 네오 시냅스 (SF 미래 / 사이버 해커)
- **설정**: 남성 / 사이보그
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall cyberpunk hacker, facing left, cyan visor, in neutral idle stance, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall cyberpunk hacker, facing left, in combat ready stance with green digital code lines scrolling on holographic screen, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall cyberpunk hacker, facing left, in dynamic attack strike pose firing green electric lasers from cyborg arms, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall cyberpunk hacker, facing left, in healing recovery pose, medical green pixels restoring cybernetics, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall cyberpunk hacker, facing left, in defeated knocked out pose, visor cracked and flickering red "ERROR", flat 2d game vector style, white background`

### 10. 이시스 (이집트 과거 / 모래 폭풍 제사장)
- **설정**: 여성 / 인간
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall Egyptian priestess, facing left, gold dress, in neutral idle stance, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall Egyptian priestess, facing left, in combat ready stance sands lifting up around feet, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall Egyptian priestess, facing left, in dynamic attack strike pose casting a swirling mini sandstorm blast forward, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall Egyptian priestess, facing left, in healing recovery pose, emerald light of Ra healing wounds, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall Egyptian priestess, facing left, in defeated knocked out pose, buried in sands, eyes closed, flat 2d game vector style, white background`

### 11. 로키 (서양 신화 / 환각의 장난꾼)
- **설정**: 남성 / 요툰족
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall Loki, facing left, green clothes, in neutral idle stance holding daggers, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall Loki, facing left, in combat ready stance creating mirror image shadows, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall Loki, facing left, in dynamic attack strike pose throwing green magical clones forward, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall Loki, facing left, in healing recovery pose, misty green magic healing wounds, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall Loki, facing left, in defeated knocked out pose, illusion dissolving, lying down, flat 2d game vector style, white background`

### 12. 아르카나 (스팀펑크 / 시공의 인형사)
- **설정**: 여성 / 오토마톤
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall steampunk automaton doll, facing left, in neutral idle stance holding giant pocket watch, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall automaton, facing left, in combat ready stance gears on back spinning rapidly, watch face glowing yellow, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall automaton, facing left, in dynamic attack strike pose swinging pocket watch forward with golden chronos clock waves, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall automaton, facing left, in healing recovery pose, oil and brass pieces repairing automatically with green glow, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall automaton, facing left, in defeated knocked out pose, gears broken scattered on floor, eyes as dead "X", flat 2d game vector style, white background`

---

## 🏹 궁수 (Archer)

### 13. 한결 (조선 과거 / 신기전 궁수)
- **설정**: 남성 / 인간
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall Korean archer, black gat hat, blue hanbok, facing left, in neutral idle stance holding bow, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall Korean archer, facing left, in combat ready stance aiming bow with multiple rocket arrows glowing orange, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall Korean archer, facing left, in dynamic attack strike pose releasing arrows firing rocket fire trails forward, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall Korean archer, facing left, in healing recovery pose surrounded by glowing green traditional charms, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall Korean archer, facing left, in defeated knocked out pose, gat hat fallen off, bow split, flat 2d game vector style, white background`

### 14. 윈드러너 (판타지 / 질풍의 엘프 궁수)
- **설정**: 여성 / 엘프
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall Elf archer, facing left, green leaf armor, in neutral idle stance holding wind bow, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall Elf archer, facing left, in combat ready stance drawing bow string with a glowing wind arrow, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall Elf archer, facing left, in dynamic attack strike pose launching a giant green wind gale arrow forward, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall Elf archer, facing left, in healing recovery pose surrounded by forest spirit sparkles, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall Elf archer, facing left, in defeated knocked out pose, lying face down, arrows scattered, flat 2d game vector style, white background`

### 15. 벡터 (SF 미래 / 플라즈마 레일건 스나이퍼)
- **설정**: 남성 / 사이보그
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall cyborg sniper, facing left, in neutral idle stance holding plasma rifle, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall cyborg sniper, facing left, in combat ready stance laser scope aiming forward, rifle glowing blue, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall cyborg sniper, facing left, in dynamic attack strike pose firing a massive cyan plasma laser blast, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall cyborg sniper, facing left, in healing recovery pose, medical lasers stitching armor plates, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall cyborg sniper, facing left, in defeated knocked out pose, battery low icon glowing red, broken gun, flat 2d game vector style, white background`

### 16. 무명 (무협 / 비수술사)
- **설정**: 여성 / 인간
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall ninja assassin, facing left, dark gray ninja suit, in neutral idle stance, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall ninja assassin, facing left, in combat ready stance crouching with multiple daggers in hands, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall ninja assassin, facing left, in dynamic attack strike pose throwing a storm of silver daggers forward, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall ninja assassin, facing left, in healing recovery pose surrounded by white cherry blossoms healing light, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall ninja assassin, facing left, in defeated knocked out pose, mask torn, scarf loose, eyes closed, flat 2d game vector style, white background`

### 17. 셰이드 (다크 판타지 / 그림자 추적자)
- **설정**: 남성 / 언데드
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall dark archer, facing left, hood covering face, in neutral idle stance holding shadow bow, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall dark archer, facing left, in combat ready stance eyes glowing blood-red, arrow charging dark aura, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall dark archer, facing left, in dynamic attack strike pose releasing a spectral shadow wolf arrow, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall dark archer, facing left, in healing recovery pose, souls repairing dark bones with green sparks, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall dark archer, facing left, in defeated knocked out pose, phantom body dissipating into smoke on floor, flat 2d game vector style, white background`

### 18. 아르테미스 (그리스 신화 / 은빛 월광의 헌터)
- **설정**: 여성 / 신족
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall Goddess hunter, facing left, moon tiara, white toga, in neutral idle stance, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall Goddess hunter, facing left, in combat ready stance bow glowing with silver crescent moon light, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall Goddess hunter, facing left, in dynamic attack strike pose shooting silver moonlight projectile creating moon mark, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall Goddess hunter, facing left, in healing recovery pose bathed in silver moon beam healing light, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall Goddess hunter, facing left, in defeated knocked out pose, bow dropped, lying on grass, eyes closed, flat 2d game vector style, white background`

---

## 🌿 힐러 (Healer)

### 19. 다솜 (동양 무속 / 영혼의 방울무당)
- **설정**: 여성 / 인간
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall Mudang priestess, colorful hanbok, facing left, in neutral idle stance holding bell staff, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall Mudang priestess, facing left, in combat ready stance shaking bells creating golden sound waves, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall Mudang priestess, facing left, in dynamic attack strike pose casting a splash of glowing blue spirit water, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall Mudang priestess, facing left, in healing recovery pose, talismans circling with green warm aura, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall Mudang priestess, facing left, in defeated knocked out pose, bells broken, lying down dizzy, flat 2d game vector style, white background`

### 20. 엘라 (서양 판타지 / 세계수 사제)
- **설정**: 여성 / 페어리
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall Fairy healer, white robes, facing left, in neutral idle stance holding vine staff, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall Fairy healer, facing left, in combat ready stance wing flapping, staff gem glowing emerald green, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall Fairy healer, facing left, in dynamic attack strike pose shooting green leaf beams forward, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall Fairy healer, facing left, in healing recovery pose, leaf sparkles and wind mending wounds, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall Fairy healer, facing left, in defeated knocked out pose, wings folded, staff broken, flat 2d game vector style, white background`

### 21. 바이오 닥터 (SF 미래 / 나노 메딕)
- **설정**: 남성 / 인간
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall combat medic, hazmat suit, facing left, in neutral idle stance holding injector gun, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall combat medic, facing left, in combat ready stance injector gun charging glowing orange liquid, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall combat medic, facing left, in dynamic attack strike pose firing glowing orange nanobot shield bullets, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall combat medic, facing left, in healing recovery pose, nanobots spraying green healing aura, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall combat medic, facing left, in defeated knocked out pose, helmet cracked, gun dropped, flat 2d game vector style, white background`

### 22. 메디아 (그리스 신화 / 물의 약초학자)
- **설정**: 여성 / 님프
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall Water nymph, facing left, hair of water, in neutral idle stance holding potion vial, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall Water nymph, facing left, in combat ready stance water bubbles orbiting around body, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall Water nymph, facing left, in dynamic attack strike pose casting a splash of glowing water bubbles, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall Water nymph, facing left, in healing recovery pose, glowing green water sparkles, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall Water nymph, facing left, in defeated knocked out pose, water hair evaporated, lying dry, flat 2d game vector style, white background`

### 23. 무정 (무협 / 소림 의술승)
- **설정**: 남성 / 인간
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall Shaolin monk, orange robes, facing left, in neutral idle stance, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall Shaolin monk, facing left, in combat ready stance chanting with glowing golden scripture barrier, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall Shaolin monk, facing left, in dynamic attack strike pose pushing palm forward creating golden dome shockwave, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall Shaolin monk, facing left, in healing recovery pose, warm golden light enveloping, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall Shaolin monk, facing left, in defeated knocked out pose, beads broken, lying on floor, flat 2d game vector style, white background`

### 24. 헤르메스 (신화 / 신들의 전령)
- **설정**: 남성 / 신족
- **모션별 프롬프트**:
  - **대기 (Idle)**: `chibi 2-head-tall Hermes, winged helmet, facing left, in neutral idle stance holding caduceus staff, flat 2d game vector style, white background`
  - **준비 (Ready)**: `chibi 2-head-tall Hermes, facing left, in combat ready stance wings on sandals fluttering, staff glowing with yellow speed wind, flat 2d game vector style, white background`
  - **타격 (Attack)**: `chibi 2-head-tall Hermes, facing left, in dynamic attack strike pose pointing staff forward releasing yellow wind tornado, flat 2d game vector style, white background`
  - **회복 (Recover)**: `chibi 2-head-tall Hermes, facing left, in healing recovery pose surrounded by green light feathers and speed dust, flat 2d game vector style, white background`
  - **기절 (Faint)**: `chibi 2-head-tall Hermes, facing left, in defeated knocked out pose, helmet fallen, lying flat, wings stopped, flat 2d game vector style, white background`
