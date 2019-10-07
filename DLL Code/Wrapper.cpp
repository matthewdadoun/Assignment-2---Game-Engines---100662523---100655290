//
#include "Wrapper.h"
#include "AssignmentClass.h"

AssignmentClass assignmentClass;

PLUGIN_API void saveCoordinates(char object, float x, float y, float z)
{
	return assignmentClass.saveCoordinates(object, x, y, z);
}

PLUGIN_API void overwriteCoordinates()
{

}

PLUGIN_API float LoadCoordinateX()
{
	return assignmentClass.LoadCoordinateX();
}

PLUGIN_API float LoadCoordinateY()
{
	return assignmentClass.LoadCoordinateY();
}

PLUGIN_API float LoadCoordinateZ()
{
	return assignmentClass.LoadCoordinateZ();
}
