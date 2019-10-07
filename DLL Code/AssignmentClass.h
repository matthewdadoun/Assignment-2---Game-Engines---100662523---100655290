#pragma once
#include "PluginSettings.h"
#include <fstream>
#include <iostream>
#include <cstring>
#include <sstream>

class PLUGIN_API AssignmentClass
{
public:
	float savedX =0.0f, savedY = 0.0f, savedZ=0.0f;
	std::ifstream infile;
	std::ofstream outfile;
	int offset = -4;
	char objectType;
	void saveCoordinates(char object, float x, float y, float z);
	void overwriteCoordinates();
	float LoadCoordinateX();
	float LoadCoordinateY();
	float LoadCoordinateZ();



};