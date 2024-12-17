#include <scip/scip.h>

int main() {
    SCIP* scip;
    SCIP_CALL(SCIPcreate(&scip));

    SCIPcreateVarBasic(scip, );

    SCIP_CALL(SCIPfree(&scip));
    BMScheckEmptyMemory();
    return 0;
}
