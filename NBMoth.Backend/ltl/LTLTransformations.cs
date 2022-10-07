using System;
using System.Collections;
using System.Collections.Generic;

import com.google.common.reflect.ClassPath;
import de.bmoth.parser.ast.nodes.ltl.LTLNode;
import de.bmoth.parser.ast.visitors.ASTTransformation;
import de.bmoth.parser.ast.visitors.ASTTransformationVisitor;

public class LTLTransformations {
    private readonly ClassLoader loader = Thread.currentThread().getContextClassLoader();
    private readonly Logger logger = Logger.getLogger(getClass().getName());

    private static LTLTransformations instance;

    private readonly List<ASTTransformation> transformationList;

    private LTLTransformations() {
        this.transformationList = new ArrayList<ASTTransformation>();

        //try {
        //    for (readonly ClassPath.ClassInfo info : ClassPath.from(loader).getTopLevelClasses()) {
        //        if (info.getName().startsWith("de.bmoth.backend.ltl.transformation")) {
        //            final Class<?> clazz = info.load();
        //            transformationList.add((ASTTransformation) clazz.newInstance());
        //        }
        //    }
        //} catch (IOException | InstantiationException | IllegalAccessException e) {
        //    logger.log(Level.SEVERE, "Error loading LTL transformation rules", e);
        //}
    }

    private static LTLTransformations getInstance() {
        if (null == instance) {
            instance = new LTLTransformations();
        }
        return instance;
    }

    public static LTLNode transformLTLNode(LTLNode ltlNode) {
        LTLTransformations astTransformationForZ3 = LTLTransformations.getInstance();
        ASTTransformationVisitor visitor = new ASTTransformationVisitor(astTransformationForZ3.transformationList);
        return visitor.transformLTLNode(ltlNode);
    }

}
