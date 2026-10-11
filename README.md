# Nekton

A beginner-friendly 2D Unity starter project for a procedurally generated bullet hell roguelike metroidvania set in the deep ocean.

## Game concept

Nekton follows Blub, a young fish born in the warm shallows of the Coral Expanse. The sea is dying. The ocean's heart has been fractured into ancient fragments, and each shard awakens a new layer of the abyss. Blub dives deeper through dangerous zones, fighting through generated combat rooms, uncovering the truth behind the ocean's collapse, and deciding whether to save the sea or consume it.

The game mixes:
- Bullet hell combat
- Roguelike room generation
- Metroidvania progression
- Exploration across multiple ocean zones
- Story-driven NPC interactions
- A secret ending hidden behind risky choices

## Story and lore

### The world

The ocean is not merely a place. It is a living memory. The ancient abyss below the surface holds the final remains of a forgotten civilization: the Elders of the Deep. They were once guardians of the ocean's balance, but they broke the world's rhythm in their attempt to ascend beyond mortality.

The ocean began to "sleep." Coral reefs dimmed, kelp forests twisted, and the sea's oldest creatures stopped singing. The deeper you travel, the more the reality of the ocean itself becomes unstable.

### Main character

Blub is not a warrior by birth. He is a curious, brave small fish who follows the light of a fractured relic into the abyss. He bears no prophecy of greatness — only a simple instinct: to keep moving downward, because the sea is calling him deeper.

### The fragments

As Blub explores, he gathers fragments of the ocean's broken heart. Each fragment reveals a piece of the truth:
- Some were made by the Elders to preserve the ocean.
- Some were made to imprison the Leviathan beneath the Core.
- Some were created by the ocean itself to choose who may rule its depths.

### The NPCs

- Tide: the first guide. Teaches movement, combat, and the promise that every fish has a current that can carry them further.
- Marin: a scout from the Kelp Forest. She tells Blub that fragments are not treasure — they are memories. The wrong memory can awaken the wrong monster.
- Bram: a deep-sea smith from the Moonlit Trench. He sharpens Blub's weapons and reveals movement upgrades, teaching him to fight with instinct as much as speed.
- Sage: the Oracle of the Deep. Sage speaks in riddles and offers dangerous upgrades. Sage knows the true ending — and knows the cost of choosing it.
- The Leviathan: not merely a boss, but the final guardian of the deep. It is the ocean's answer to those who seek to become too powerful.

## Short cutscene script

### Opening cutscene

[Black screen. A distant pulse glows in the deep blue.] 
Narrator: "For ages, the sea was kind. It fed the living. It carried memories. It kept the balance."

[Blub swims through a shimmering reef as the water grows darker.] 
Narrator: "Then the light split. The heart of the ocean cracked."

[The camera drops below the coral. A large broken crystal floats in the dark.] 
Narrator: "The fragments scattered. The abyss awoke."

[Blub sees a glow beneath him. A voice whispers.] 
Tide: "The deeper you swim, the more the sea remembers. Follow the light, little fish. But do not let it decide for you."

[Blub darts downward into the dark.] 
Narrator: "And so the descent began."

### Midgame cutscene

[The Kelp Forest glows with bioluminescent fragments.] 
Marin: "Every fragment you take is a memory. It is not yours to keep. Only choose the ones that tell the truth."

[Blub continues deeper, entering the Moonlit Trench.] 
Bram: "The deeper you go, the more your body changes. Your fins can become blades. Your instincts can become weapons."

[Sage appears beyond the trench, floating in a ring of pale light.] 
Sage: "You are not here to save the ocean. You are here to decide what the ocean becomes."

### Final boss cutscene

[Blub reaches the black heart of the Core.] 
Narrator: "Beneath the crushing dark, the Leviathan sleeps. It was once the ocean's judge. It is now the last gate."

[The Leviathan opens its eyes as the sea trembles.] 
The Leviathan: "You came for the fragments. You came for the truth. But the truth has teeth."

## Secret ending

The secret ending is hidden behind a risky choice in the final zone.

If Blub accepts Sage's forbidden upgrade, he gains immense power at the cost of his identity. His body mutates, he becomes more than fish, and he opens a path to the deepest, oldest chamber in the ocean.

There, the truth is revealed:
- The ocean did not break by accident.
- The Elders wanted to become gods by merging their souls with the ocean's heart.
- Blub's choice decides whether the sea continues under fear, or whether it is reborn without a tyrant.

### Secret ending path

If the player chooses:
- To trust the ocean and free the Leviathan, the sea shifts back to balance and the abyss becomes a guardian instead of a prison.
- To merge with the Core and become the new heart of the sea, the game reveals a darker true ending where Blub becomes the ocean's new tyrant.
- To reject all upgrades and fight the Leviathan as a pure, uncorrupted fish, the player reaches the purest ending: the ocean survives, but Blub returns to the shallows as a myth.

## Easter eggs

- A hidden shrine in the Coral Expanse contains a message: "The sea remembers all that were lost."
- In the Moonlit Trench, graffiti carved into rock reads "Beneath the light, there is still a voice."
- If the player stands still in the Core for too long, the Leviathan whispers a line from the opening narration in reverse.
- A rare chest in the Kelp Forest contains a small pearl labeled "For the one who goes below."
- Sage's room contains tiny fish bones arranged into a spiral, hinting that the Oracle may once have been a fish before becoming something else.

## Beginner-friendly Unity kickoff

This repo is a starter foundation for a Unity 2D game.

### Files included

- `Assets/Scripts/Player/PlayerController2D.cs` — basic fish movement and dash
- `Assets/Scripts/Combat/PlayerCombatController.cs` — shoot projectiles with mouse input
- `Assets/Scripts/Combat/Projectile.cs` — projectile movement and collision logic
- `Assets/Scripts/World/ProceduralRoomGenerator.cs` — simple room generation for combat rooms
- `Assets/Scripts/NPC/NPCDialogue.cs` — NPC interaction logic
- `Assets/Scripts/Story/NektonStory.cs` — story and lore data
- `Assets/Scripts/Story/CutsceneController.cs` — short cutscene flow
- `Assets/Scripts/Progress/FragmentPickup.cs` — collectible fragments
- `Assets/Scripts/Managers/GameManager.cs` — progression and zone tracking

### Unity setup

1. Create a new Unity 2D project.
2. In your Unity project, create folders matching the structure in this repo.
3. Copy the scripts into `Assets/Scripts/...`.
4. Create simple GameObjects for:
   - Player
   - Enemy spawner
   - Projectile prefab
   - NPCs
   - Main camera
5. Add a `Rigidbody2D` and `Collider2D` to the player.
6. Add a `BoxCollider2D` or `CircleCollider2D` to NPCs, then assign the NPC dialogue script.
7. Add a UI text object for dialogue if you want to see the messages during play.

### Suggested first step

Build a small playable prototype with:
- Player movement
- Mouse aim and shooting
- One enemy type
- One NPC dialogue interaction
- One procedural room generator
- A title screen or intro cutscene

Then expand by adding:
- More enemy patterns
- Boss room logic
- More zones
- Upgrade cards
- Save/progression logic

## Recommended development plan

### Phase 1: basic playable loop
- movement
- shooting
- enemy collisions
- room generation
- pickups

### Phase 2: metroidvania loop
- zone unlocks
- NPC progression
- ability upgrades
- fragments

### Phase 3: action-heavy combat
- enemy bullet patterns
- stronger boss AI
- weapon upgrades
- final boss fight

### Phase 4: narrative depth
- lore pickups
- lore-based cutscenes
- secret ending trigger
- final choice sequence

## Notes for beginners

- Keep systems simple and separated: movement, combat, NPC, room generation, story.
- Use one script per system.
- Prototype tiny features first before expanding.
- Focus on making the player feel fast and dangerous underwater.
- The most important part of a game like this is readability and clarity. A simple player loop with strong feedback will always beat complexity.

## License

This project is intended as a passion project starter for a small 2D metroidvania bullet hell.

## Credits

Built as a foundation for Nekton by Devanino13.

---

If you want, the next step is to generate the actual Unity-ready script files and a full folder structure for the project so you can drop them directly into a fresh Unity 2D project.
