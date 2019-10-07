#pragma once
#include "PluginSettings.h"
#include "AssignmentClass.h"

#ifdef __cplusplus
extern "C"
{
#endif

	//Put Functions here
PLUGIN_API	void saveCoordinates(char object, float x, float y, float z);
PLUGIN_API  void overwriteCoordinates();
PLUGIN_API	float LoadCoordinateX();
PLUGIN_API  float LoadCoordinateY();
PLUGIN_API	float LoadCoordinateZ();

#ifdef __cplusplus
}
#endif
