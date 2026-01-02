// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "ExiledAgainGameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AExiledAgainGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AExiledAgainGameMode();
};



